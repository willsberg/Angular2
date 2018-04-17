using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SourcecastReportsApi.Models;

namespace SourcecastReportsApi.Controllers
{
    public class StateJobDataController : ApiController
    {
        // GET: StateJobData
        public IEnumerable<StateJobInfoDataFields> GetJobData(string stateJobId)
        {
            List<StateJobInfoDataFields> datalist = null;
            StateJobInfoData sd = new StateJobInfoData();
            datalist = new List<StateJobInfoDataFields>();

            DataTable x = sd.GetJcJobIds();

            foreach (DataRow dataRow in x.Rows)
            {
                StateJobInfoDataFields data = new StateJobInfoDataFields { jobID = dataRow["JC_JOB_ID"].ToString(),
                    state = dataRow["STATE"].ToString(),
                    status = sd.GetStatusList().Shuffle().FirstOrDefault(), stateJobID = stateJobId};

                datalist.Add(data);
            }

            return datalist;

        }

        
    }
}