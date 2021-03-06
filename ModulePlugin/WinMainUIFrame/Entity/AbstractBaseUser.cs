﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.CoreFrame.Orm;
using ProtoBuf;

namespace WinMainUIFrame.Entity
{
    [Serializable]
    [ProtoContract]
    [Table(TableName = "BaseUser", EntityType = EntityType.Table, IsGB = false)]
    public class BaseUser:EFWCoreLib.CoreFrame.Business.AbstractEntity
    {
        private int  _userid;
        /// <summary>
        /// ID
        /// </summary>
        [Column(FieldName = "UserId", DataKey = true,  Match = "", IsInsert = false)]
        [ProtoMember(1)]
        public int UserId
        {
            get { return  _userid; }
            set {  _userid = value; }
        }

        private int  _empid;
        /// <summary>
        /// 人员编号
        /// </summary>
        [Column(FieldName = "EmpId", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(2)]
        public int EmpId
        {
            get { return  _empid; }
            set {  _empid = value; }
        }

        private string  _code;
        /// <summary>
        /// 用户名
        /// </summary>
        [Column(FieldName = "Code", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(3)]
        public string Code
        {
            get { return  _code; }
            set {  _code = value; }
        }

        private string  _password;
        /// <summary>
        /// 密码
        /// </summary>
        [Column(FieldName = "PassWord", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(4)]
        public string PassWord
        {
            get { return  _password; }
            set {  _password = value; }
        }

        private int  _groupid;
        /// <summary>
        /// 所属组
        /// </summary>
        [Column(FieldName = "GroupId", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(5)]
        public int GroupId
        {
            get { return  _groupid; }
            set {  _groupid = value; }
        }

        private int  _lock;
        /// <summary>
        /// 锁定标记
        /// </summary>
        [Column(FieldName = "Lock", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(6)]
        public int Lock
        {
            get { return  _lock; }
            set {  _lock = value; }
        }

        private string  _memo;
        /// <summary>
        /// 
        /// </summary>
        [Column(FieldName = "Memo", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(7)]
        public string Memo
        {
            get { return  _memo; }
            set {  _memo = value; }
        }

        private int  _isadmin;
        /// <summary>
        /// 
        /// </summary>
        [Column(FieldName = "IsAdmin", DataKey = false,  Match = "", IsInsert = true)]
        [ProtoMember(8)]
        public int IsAdmin
        {
            get { return  _isadmin; }
            set {  _isadmin = value; }
        }

        private int _workId;
        /// <summary>
        /// 
        /// </summary>
        [Column(FieldName = "WorkId", DataKey = false, Match = "", IsInsert = false)]
        [ProtoMember(9)]
        public int WorkId
        {
            get { return _workId; }
            set { _workId = value; }
        }
    }
}
