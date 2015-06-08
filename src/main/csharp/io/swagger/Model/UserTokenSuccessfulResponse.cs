using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IO.Swagger.Model {
  [DataContract]
  public class UserTokenSuccessfulResponse {
    
    /* Status code */
    [DataMember(Name="code", EmitDefaultValue=false)]
    public int? Code { get; set; }

    
    /* Message */
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    
    [DataMember(Name="user", EmitDefaultValue=false)]
    public UserTokenSuccessfulResponseInnerUserField User { get; set; }

    
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTokenSuccessfulResponse {\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}