﻿using ScoreSystem.Services.AreaManage;
using ScoreSystem.Services.WorkerManage;
using System;
using System.Collections;
using System.Web.Http;

namespace ScoreSystem.Controllers.WorkerManage
{
    public class DeleteWorkController : ApiController
    {

        // GET api/<controller>/5
        public Hashtable Get(int id)
        {
            Hashtable ht = new Hashtable();
            Hashtable data = new Hashtable();
            WorkInfo ai = new WorkInfo();
            if (ai.HasUsed(id))
            {
                ht.Add("code", 40000);
                data.Add("message", "工作已被使用，无法删除");
            }
            else
            {
                try
                {
                    if (ai.DeleteOne(id))
                    {
                        ht.Add("code", 20000);
                        data.Add("status", "success");
                    }
                    else
                    {
                        ht.Add("code", 40000);
                        data.Add("message", "failed");
                    }
                }
                catch (Exception e)
                {
                    ht.Add("code", 40000);
                    data.Add("message", e.Message);
                }
            }
            ht.Add("data", data);
            return ht;
        }

    }
}