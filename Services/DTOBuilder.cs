using System;
namespace projeto_radar_backend.Services
{
  public class DTOBuilder<T>
  {
    public static T Builder(object objectDTO)
    {
      var obj = Activator.CreateInstance<T>();

      foreach (var propDTO in objectDTO.GetType().GetProperties())
      {
        var propObj = obj?.GetType().GetProperty(propDTO.Name);
        if (propObj is not null)
        {
          propObj.SetValue(obj, propDTO.GetValue(objectDTO));
        }
      }
      return obj;
    }
  }
}

