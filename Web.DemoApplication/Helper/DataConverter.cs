using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DemoApplication.Models;

namespace Web.DemoApplication.Helper
{
    public class DataConverter
    {
        internal List<MemberEntity> ConvertArrayToList(DemoWcfService.MemberEntity[] memberEntitiesAry)
        {
            List<MemberEntity> memberEntities = new List<MemberEntity>();
            foreach (var memberEntity in memberEntitiesAry)
            {
                var mEntity = new MemberEntity();
                mEntity.Id = memberEntity.Id;
                mEntity.FirstName = memberEntity.FirstName;
                mEntity.LastName = memberEntity.LastName;
                mEntity.Address = memberEntity.Address;
                mEntity.ContactNo = memberEntity.ContactNo;
                memberEntities.Add(mEntity);
            }
            return memberEntities;
        }

    }
}