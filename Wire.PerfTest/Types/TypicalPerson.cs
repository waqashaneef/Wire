﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using ZeroFormatter;

namespace Wire.PerfTest.Types
{
    [DataContract]
    public enum MaritalStatus
    {
        [EnumMember]
        Married,
        [EnumMember]
        Divorced,
        [EnumMember]
        HatesAll
    }

    [ProtoContract]
    [DataContract]
    [Serializable]
    [ZeroFormattable]
    public class TypicalPersonData
    {
        /// <summary>
        /// Required by some serilizers (i.e. XML)
        /// </summary>
        public TypicalPersonData() { }


        [ProtoMember(1)]
        [DataMember]
        [Index(0)]
        public virtual string Address1 { get; set; }

        [ProtoMember(2)]
        [DataMember]
        [Index(1)]
        public virtual string Address2 { get; set; }

        [ProtoMember(3)]
        [DataMember]
        [Index(2)]
        public virtual string AddressCity { get; set; }

        [ProtoMember(4)]
        [DataMember]
        [Index(3)]
        public virtual string AddressState { get; set; }

        [ProtoMember(5)]
        [DataMember]
        [Index(4)]
        public virtual string AddressZip { get; set; }

        [ProtoMember(6)]
        [DataMember]
        [Index(5)]
        public virtual double CreditScore { get; set; }

        [ProtoMember(7)]
        [DataMember]
        [Index(6)]
        public virtual DateTime DOB { get; set; }

        [ProtoMember(8)]
        [DataMember]
        [Index(7)]
        public virtual string EMail { get; set; }

        [ProtoMember(9)]
        [DataMember]
        [Index(8)]
        public virtual string FirstName { get; set; }

        [ProtoMember(10)]
        [DataMember]
        [Index(9)]
        public virtual string HomePhone { get; set; }

        [ProtoMember(11)]
        [DataMember]
        [Index(10)]
        public virtual string LastName { get; set; }

        [ProtoMember(12)]
        [DataMember]
        [Index(11)]
        public virtual MaritalStatus MaritalStatus { get; set; }

        [ProtoMember(13)]
        [DataMember]
        [Index(12)]
        public virtual string MiddleName { get; set; }

        [ProtoMember(14)]
        [DataMember]
        [Index(13)]
        public virtual string MobilePhone { get; set; }

        [ProtoMember(15)]
        [DataMember]
        [Index(14)]
        public virtual bool RegisteredToVote { get; set; }

        [ProtoMember(16)]
        [DataMember]
        [Index(15)]
        public virtual decimal Salary { get; set; }

        [ProtoMember(17)]
        [DataMember]
        [Index(16)]
        public virtual int YearsOfService { get; set; }



        [ProtoMember(18)]
        [DataMember]
        [Index(17)]
        public virtual string SkypeID { get; set; }
        [ProtoMember(19)]
        [DataMember]
        [Index(18)]
        public virtual string YahooID { get; set; }
        [ProtoMember(20)]
        [DataMember]
        [Index(19)]
        public virtual string GoogleID { get; set; }

        [ProtoMember(21)]
        [DataMember]
        [Index(20)]
        public virtual string Notes { get; set; }

        [ProtoMember(22)]
        [DataMember]
        [Index(21)]
        public virtual bool? IsSmoker { get; set; }
        [ProtoMember(23)]
        [DataMember]
        [Index(22)]
        public virtual bool? IsLoving { get; set; }
        [ProtoMember(24)]
        [DataMember]
        [Index(23)]
        public virtual bool? IsLoved { get; set; }
        [ProtoMember(25)]
        [DataMember]
        [Index(24)]
        public virtual bool? IsDangerous { get; set; }
        [ProtoMember(26)]
        [DataMember]
        [Index(25)]
        public virtual bool? IsEducated { get; set; }
        [ProtoMember(27)]
        [DataMember]
        [Index(26)]
        public virtual DateTime? LastSmokingDate { get; set; }

        [ProtoMember(28)]
        [DataMember]
        [Index(27)]
        public virtual decimal? DesiredSalary { get; set; }
        [ProtoMember(29)]
        [DataMember]
        [Index(28)]
        public virtual double? ProbabilityOfSpaceFlight { get; set; }

        [ProtoMember(30)]
        [DataMember]
        [Index(29)]
        public virtual int? CurrentFriendCount { get; set; }
        [ProtoMember(31)]
        [DataMember]
        [Index(30)]
        public virtual int? DesiredFriendCount { get; set; }


        private static int counter;
        public static TypicalPersonData MakeRandom()
        {
            var rnd = counter++;

            var data = new TypicalPersonData
            {
                FirstName = NaturalTextGenerator.GenerateFirstName(),
                MiddleName = NaturalTextGenerator.GenerateFirstName(),
                LastName = NaturalTextGenerator.GenerateLastName(),
                DOB = DateTime.Now.AddYears(5),
                Salary = 55435345,
                YearsOfService = 25,
                CreditScore = 0.7562,
                RegisteredToVote = (DateTime.UtcNow.Ticks & 1) == 0,
                MaritalStatus = MaritalStatus.HatesAll,
                Address1 = NaturalTextGenerator.GenerateAddressLine(),
                Address2 = NaturalTextGenerator.GenerateAddressLine(),
                AddressCity = NaturalTextGenerator.GenerateCityName(),
                AddressState = "CA",
                AddressZip = "91606",
                HomePhone = (DateTime.UtcNow.Ticks & 1) == 0 ? "(555) 123-4567" : null,
                EMail = NaturalTextGenerator.GenerateEMail()
            };

            if (0 != (rnd & (1 << 32))) data.Notes = NaturalTextGenerator.Generate(45);
            if (0 != (rnd & (1 << 31))) data.SkypeID = NaturalTextGenerator.GenerateEMail();
            if (0 != (rnd & (1 << 30))) data.YahooID = NaturalTextGenerator.GenerateEMail();

            if (0 != (rnd & (1 << 29))) data.IsSmoker = 0 != (rnd & (1 << 17));
            if (0 != (rnd & (1 << 28))) data.IsLoving = 0 != (rnd & (1 << 16));
            if (0 != (rnd & (1 << 27))) data.IsLoved = 0 != (rnd & (1 << 15));
            if (0 != (rnd & (1 << 26))) data.IsDangerous = 0 != (rnd & (1 << 14));
            if (0 != (rnd & (1 << 25))) data.IsEducated = 0 != (rnd & (1 << 13));

            if (0 != (rnd & (1 << 24))) data.LastSmokingDate = DateTime.Now.AddYears(-10);


            if (0 != (rnd & (1 << 23))) data.DesiredSalary = rnd / 1000m;
            if (0 != (rnd & (1 << 22))) data.ProbabilityOfSpaceFlight = rnd / (double)int.MaxValue;

            if (0 != (rnd & (1 << 21)))
            {
                data.CurrentFriendCount = rnd % 123;
                data.DesiredFriendCount = rnd % 121000;
            }

            return data;
        }
    }

    public class NaturalTextGenerator
    {
        public static string GenerateEMail()
        {
            return "foo@fooo.com";
        }

        public static string Generate(int i)
        {
            return "fskldjflksjfl ksj dlfkjsdfl ksdjklf jsdlkj" + DateTime.Now.Ticks;
        }

        public static string GenerateAddressLine()
        {
            return "fkjdskfjskfjs" + DateTime.Now.Ticks;
        }

        public static string GenerateFirstName()
        {
            return "fksjdfkjsdkfjksdfs" + DateTime.Now.Ticks;
        }

        public static string GenerateCityName()
        {
            return "fksdfkjsdkfjsdkfs";
        }

        public static string GenerateLastName()
        {
            return "kfjdskdfjskj";
        }
    }

    public class ExternalRandomGenerator
    {
    }
}
