using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.ComponentModel;

using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.WinApp
{
    public class AdminDataSync
    {
        BackgroundWorker _worker;

        public AdminDataSync()
        {
            _worker = new BackgroundWorker();
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += new DoWorkEventHandler(_worker_DoWork);
            _worker.ProgressChanged += new ProgressChangedEventHandler(_worker_ProgressChanged);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_worker_RunWorkerCompleted);           
        }

        public void Sync()
        {
            _worker.RunWorkerAsync();
        }

        public ProgressChangedEventHandler SyncProgressChanged
        {
            set { _worker.ProgressChanged += value; }
        }

        public RunWorkerCompletedEventHandler SyncCompleted
        {
            set { _worker.RunWorkerCompleted += value; }
        }

        void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (e.Cancel == false)
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                //upload the data first so that we will get the latest data when we download from server
                if (ACS.TouristTicket.Common.ACSCUtility.IsConnectedToService())
                {
                    worker.ReportProgress(0, new SyncInfo() {IsConnected = true, Status = ""});
                    System.Threading.Thread.Sleep(1000);
                    UpSync(worker);
                    System.Threading.Thread.Sleep(1000);
                    DownSync(worker);
                    System.Threading.Thread.Sleep(1000);
                    //clear the status
                    worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "" });
                    //update last downloaded/uploaded date
                    //worker.ReportProgress(1, new ACSFDataSync().RetrieveClientUploadDownloadLog());
                }
                else
                {
                    worker.ReportProgress(0, new SyncInfo() { IsConnected = false, Status = "" });
                }
                System.Threading.Thread.Sleep(Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SyncIntervalInSeconds"])*1000);
            }
        }

        private void UpSync(BackgroundWorker worker)
        {
            try
            {
                worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "Checking for uploads..." });
                ACS.TouristTicket.Facade.ACSFCUpSync localDataSyncService = new ACSFCUpSync();
                using (AdminSyncService.SyncServiceClient remoteDataSyncService = new AdminSyncService.SyncServiceClient())
                {
                    //retrieve data to download
                    ACSSyncData syncData = localDataSyncService.GetUpSyncData();
                    if (syncData.TotalRecords > 0)
                    {
                        do
                        {
                            worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "Uploading (" + syncData.TotalRecords + ") records." });
                            ACSSyncData updatedRecord = remoteDataSyncService.SyncData(syncData);
                            localDataSyncService.UpdateLastUpSyncDate(updatedRecord);
                            //retrieve data again
                            syncData = localDataSyncService.GetUpSyncData();

                        } while (syncData.TotalRecords > 0);
                    }
                    System.Threading.Thread.Sleep(1000);
                    worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "", LastUploadedDate = DateTime.Now });
                }
            }
            catch
            {

            }
        }

        private void DownSync(BackgroundWorker worker)
        {
            try
            {
                worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "Checking for downloads..." });
                ACS.TouristTicket.Facade.ACSFCSync localDataSyncService = new ACSFCSync();
                using (AdminSyncService.SyncServiceClient remoteDataSyncService = new AdminSyncService.SyncServiceClient())
                {
                    //retrieve data to download
                    ACSSyncData syncData = remoteDataSyncService.GetDownSyncData();
                    if (syncData.TotalRecords > 0)
                    {
                        do
                        {
                            worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "Downloading (" + syncData.TotalRecords + ") records." });
                            ACSSyncData updatedRecords = localDataSyncService.SyncData(syncData);
                            remoteDataSyncService.UpdateLastDownSyncDate(updatedRecords);
                            //retrieve data again
                            //syncData.TotalRecords = 0;
                            syncData = remoteDataSyncService.GetDownSyncData();

                        } while (syncData.TotalRecords > 0);
                    }
                    System.Threading.Thread.Sleep(1000);
                    worker.ReportProgress(0, new SyncInfo() { IsConnected = true, Status = "", LastDownloadedDate = DateTime.Now });
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
