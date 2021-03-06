﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Company
    {
        private readonly IList<Worker> _workers;

        public Company()
        {
            _workers = new List<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public string WorkerReportPlainText
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                foreach (var worker in _workers)
                {
                    if (builder.Length > 0)
                        builder.Append(Environment.NewLine);
                    builder.Append(worker.ReportPlainText);
                }
                return builder.ToString();
            }
        }

        public string WorkerReportJson
        {
            get
            {
                StringBuilder builder = new StringBuilder("[");
                foreach (var worker in _workers)
                {
                    if (builder.Length > 1)
                        builder.Append(",");
                    builder.Append(worker.ReportJson);
                }
                builder.Append("]");
                return builder.ToString();
            }
        }
    }
}
