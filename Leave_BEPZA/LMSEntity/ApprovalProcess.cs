﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using System.Globalization;

namespace LMSEntity
{
    public class ApprovalProcess : EntityBase
    {
        public ApprovalProcess() { }

        [DataMember, DataColumn(true)]
        public System.Int32 intApprovalProcessId { get; set; }

        [DataMember, DataColumn(true)]
        public System.Int32 intModuleId { get; set; }
                   
        [DataMember, DataColumn(true)]
        public System.String strApprovalProcessName { get; set; }

        [DataMember, DataColumn(true)]
        public System.String strIUser { get; set; }

        [DataMember, DataColumn(true)]
        public System.DateTime dtIDate { get; set; }

        [DataMember, DataColumn(true)]
        public System.String strEUser { get; set; }

        [DataMember, DataColumn(true)]
        public System.DateTime dtEDate { get; set; }
    }
}
