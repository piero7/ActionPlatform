using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActionPlatform.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string OpenId { get; set; }


        public string NickName { get; set; }

        public bool subscribe { get; set; }

        [EnumDataType(typeof(Sex))]
        public Sex Sex { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }

        public string Language { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? SubscribeTime { get; set; }

        public string Headimgurl { get; set; }

        public int? Level { get; set; }

        public string Remarks { get; set; }

        [EnumDataType(typeof(Part))]
        public Part Part { get; set; }


    }

    public enum Sex
    {
        男 = 1,
        女 = 2,
        未知 = 0,
    }

    public enum Part
    {
        未知 = 0,
        普通用户 = 1,
        组织者 = 2,
        管理员 = 999
    }


}