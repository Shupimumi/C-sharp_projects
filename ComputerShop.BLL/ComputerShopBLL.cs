using ComputerShop.Abstract;
using ComputerShop.DAL.Abstract;
using ComputerShop.DAL.DB;
using ComputerShop.DAL.FakeDAL;
using ComputerShop.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.BLL
{

    public class ComputerShopBLL : IComputerShopBLL
    {
        IComputerShopDAL dal;
        public ComputerShopBLL()
        {
            string typeDAL = "";
            try
            {
                typeDAL = ConfigurationManager.AppSettings["DAL"];
            }
            catch (Exception e)
            {
                throw new ApplicationException("error in configuration file");
            }
            switch (typeDAL)
            {
                case "FAKE":
                    {
                        dal = new FakeDAL();
                    }
                    break;
                case "DB":
                    {
                        dal = new DBDAL();
                    }
                    break;
            }
        }
        public bool Add(ComputerShopDTO data)
        {
            //try
            //{
                return dal.Add(data);
            //}
            //catch (Exception e)
            //{
            //    throw new BLLUnknownException("Unknown error", e);
            //}
        }

        public ComputerShopDTO Get(Guid id)
        {
            //try
            //{
                return dal.Get(id);
            //}
            //catch (NotFoundException e)
            //{
            //    throw e;
            //}
            //catch (Exception e)
            //{
            //    throw new BLLUnknownException("Unknown error", e);
            //}
        }

        public IEnumerable<ComputerShopDTO> GetALL()
        {
            return dal.GetAll().ToArray();
        }
    

        public bool Remove(Guid id)
        {
            return dal.Remove(id);
        }

        public bool Update(ComputerShopDTO data)
        {
            return dal.Update(data);
        }
    }

}
