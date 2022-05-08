using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChangeStuffInMainForm.Classes
{
    public class SettingsOperations
    {
        public static string FileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
        public FormContainer Get(string formName)
        {
            FormContainer container = new FormContainer();

            File.ReadAllText(FileName);
            List<FormContainer> results = JsonConvert.DeserializeObject<List<FormContainer>>(File.ReadAllText(FileName));
            if (results == null)
            {
                return container;
            }
            else
            {
                return container = results.FirstOrDefault(item => item.Name == formName);
            }
        }

    }

    
    public class FormContainer
    {
        public string Name { get; set; }
        public ControlContainer Controls { get; set; }
        public override string ToString() => Name;
    }

    public class ControlContainer
    {
        public string Name { get; set; }
        public string PropertyName { get; set; }
        public Type Type { get; set; }
        public object Value { get; set; }
        public override string ToString() => Name;

    }
}
