﻿using System.Collections.Generic;

namespace GetMedia.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        virtual public ICollection<PurchaseOrder> Prudccts { get; set; }

        //to add order models and then orderitem modle as a conection table 
    }
}
