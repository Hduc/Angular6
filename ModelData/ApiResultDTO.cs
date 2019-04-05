using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;
namespace PremiumcontactMaster.ModelData
{
    [JsonObject(MemberSerialization.OptOut)]
    public class ApiResultDTO
    {
        #region Constructor
        public ApiResultDTO()
        {
        }
        #endregion
        #region Properties
        [DataMember]
        public object Result { get; set; }

        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Token{get; set;}
        public ApiResultDTO(object obj)
        {
            Result = obj;
            ErrorCode = obj != null ?  "200" : HttpStatusCode.NotFound.ToString();
            Description = obj != null ? "OK" : "Occur error";
        }
        public ApiResultDTO(object obj, string error, string description)
        {
            Result = obj;
            ErrorCode = error;
            Description = description;
        }
          public ApiResultDTO(object obj, string strToken)
        {
            Result = obj;
            Token = strToken != "" ? strToken : "";
            ErrorCode = obj != null ?  "200" : HttpStatusCode.NotFound.ToString();
            Description = obj != null ? "OK" : "Occur error";
        }
  
        public static ApiResultDTO NotFounds
        {
            get
            {
                return new ApiResultDTO { ErrorCode = "404", Description = "NotFound" };
            }
        }

        public static ApiResultDTO BadRequests
        {
            get
            {
                return new ApiResultDTO {  ErrorCode = "400", Description = "BadRequest" };
            }
        }
        #endregion
    }
}