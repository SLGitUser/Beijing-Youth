namespace BeijingYouth.Pub.Models.JSJL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Send { get; set; }

        [Required]
        [StringLength(20)]
        public string Receive { get; set; }

        [Required]
        [StringLength(200)]
        public string Content { get; set; }

        public DateTime SendDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }
    }

    public class MessageType
    {
        public enum Type
        {
            好友消息,
            系统消息
        }
    }
}
