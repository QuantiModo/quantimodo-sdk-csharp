using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Measurement {
    
    /// <summary>
    /// ORIGINAL Name of the variable for which we are creating the measurement records
    /// </summary>
    /// <value>ORIGINAL Name of the variable for which we are creating the measurement records</value>
    [DataMember(Name="variable", EmitDefaultValue=false)]
    public string Variable { get; set; }

    
    /// <summary>
    /// Application or device used to record the measurement values
    /// </summary>
    /// <value>Application or device used to record the measurement values</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /// <summary>
    /// Timestamp for the measurement event in epoch time
    /// </summary>
    /// <value>Timestamp for the measurement event in epoch time</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    public long? Timestamp { get; set; }

    
    /// <summary>
    /// Converted measurement value in requested unit
    /// </summary>
    /// <value>Converted measurement value in requested unit</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public double? Value { get; set; }

    
    /// <summary>
    /// Unit of measurement as requested in GET request
    /// </summary>
    /// <value>Unit of measurement as requested in GET request</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    public string Unit { get; set; }

    
    /// <summary>
    /// Measurement value in the unit as orignally submitted
    /// </summary>
    /// <value>Measurement value in the unit as orignally submitted</value>
    [DataMember(Name="storedValue", EmitDefaultValue=false)]
    public double? StoredValue { get; set; }

    
    /// <summary>
    /// Unit of measurement as originally submitted
    /// </summary>
    /// <value>Unit of measurement as originally submitted</value>
    [DataMember(Name="storedAbbreviatedUnitName", EmitDefaultValue=false)]
    public string StoredAbbreviatedUnitName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Measurement {\n");
      
      sb.Append("  Variable: ").Append(Variable).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      
      sb.Append("  StoredValue: ").Append(StoredValue).Append("\n");
      
      sb.Append("  StoredAbbreviatedUnitName: ").Append(StoredAbbreviatedUnitName).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
