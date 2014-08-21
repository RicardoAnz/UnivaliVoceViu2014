﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoceViuModel.ServiceSolicitation.Domain;

namespace VoceViuModel.ServiceSolicitation
{
    public class Advertisement
    {
        public int Id { get; set; }
        public AdvertisementStatus Status {get; set;}
        public ICollection<AdvertisementContent> DeniedContent { get; set; }
        public ContractModel ContractModel { get; set; }
        public Byte[] File { get; set; }
        public string FileName { get; set; }
    }
}