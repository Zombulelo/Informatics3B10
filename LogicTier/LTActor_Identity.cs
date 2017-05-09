﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabaseLayer;    //import DatabseLayer

namespace LogicTier
{
    public class LTActor_Identity
    {
        public LTActor_Identity objDataLayer = new LTActor_Identity();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActorId(string descript)
        {
            objDataLayer.AddActorIdDB(descript);
        }

        public void UpdateActorId(int actorid_id, string descript)
        {
            objDataLayer.UpdateActorIdDB(actorid_id, descript);
        }

        public void DeleteActorId(int actorid_id)
        {
            objDataLayer.DeleteActorIdDB(actorid_id);
        }

        public object RetrieveActorId()
        {
            return objDataLayer.RetrieveActorIdDB();
        }
    }
}
