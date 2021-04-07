using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BsiApplicationMvc.Models;

namespace BsiApplicationMvc.ViewModels
{
    public class StatementReportVM
    {
        public List<spGetTotalRecordsByAccountNumber_Result> spGetTotalRecordsByAccountNumber_VM { get; set; }

        public List<spGetTotalRecordsByDates_Result> spGetTotalRecordsByDates_VM { get; set; }

        public List<spGetTotalRecordsBy3m_Result> spGetTotalRecordsBy3m_VM { get; set; }

        public List<spGetTotalRecordsBy9m_Result> spGetTotalRecordsBy9m_VM { get; set; }

        public List<spGetTotalRecordsBy30d_Result> spGetTotalRecordsBy30d_VM { get; set; }

        public List<spGetTotalRecordsBy1y_Result> spGetTotalRecordsBy1y_VM { get; set; }

        public List<spGetTotalRecordsBy2y_Result> spGetTotalRecordsBy2y_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeByAccountNumber_Result> spGetTotalRecordsWithTxnCodeByAccountNumber_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeByDates_Result> spGetTotalRecordsWithTxnCodeByDates_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeBy3m_Result> spGetTotalRecordsWithTxnCodeBy3m_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeBy9m_Result> spGetTotalRecordsWithTxnCodeBy9m_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeBy30d_Result> spGetTotalRecordsWithTxnCodeBy30d_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeBy1y_Result> spGetTotalRecordsWithTxnCodeBy1y_VM { get; set; }

        public List<spGetTotalRecordsWithTxnCodeBy2y_Result> spGetTotalRecordsWithTxnCodeBy2y_VM { get; set; }

    }
}