using System;
using System.Collections.Generic;
using System.Linq;

namespace Levismad.Utils
{
    public static class ValidationUtil
    {
        public class ValidatorResult
        {
            public ValidatorResult()
            {
                IsValid = true;
                Erros = new List<ValidatorModel>();
            }
            public bool IsValid { get; set; }
            public List<ValidatorModel> Erros { get; set; }
        }
        public class ValidatorModel
        {
            public string Campo { get; set; }
            public int TamanhoMaximo { get; set; }
            public int TamanhoReal { get; set; }
            public string Valor { get; set; }
        }
        public static ValidatorResult ValidarTamanhos(this object objeto)
        {
            var result = new ValidatorResult();
            var properties = objeto.GetType().GetProperties();
            var erros = new List<ValidatorModel>();
            foreach (var csvColumnDef in properties.Where(p => p.CustomAttributes.Any()).Select(propertie => (ValidarAttribute)propertie.GetCustomAttributes(typeof(ValidarAttribute), false).First()))
            {
                try
                {
                    var val = objeto.GetPropertyValue<string>(csvColumnDef.Nome);
                    if (val != null && val.Length > csvColumnDef.TamanhoMaximo)
                    {
                        erros.Add(new ValidatorModel() {
                            Campo = csvColumnDef.Nome,
                            TamanhoMaximo = csvColumnDef.TamanhoMaximo,
                            TamanhoReal = val.Length,
                            Valor = val
                        });
                    }
                }
                catch (Exception)
                {
                    result.IsValid = false;
                }
            }
            if (!erros.Any()) return result;
            result.IsValid = false;
            result.Erros = erros;
            return result;
        }


        private static T GetPropertyValue<T>(this object obj, string propertyName)
        {
            var propertyInfo = obj.GetType().GetProperty(propertyName);

            if (propertyInfo == null)
                throw new ArgumentException("Property " + propertyName + " not found!");

            return (T)Convert.ChangeType(propertyInfo.GetValue(obj, null), typeof(T));
        }

        /*
        public static void SetPropertyValue(this object obj, string propertyName, object value)
        {
            var propertyInfo = obj.GetType().GetProperty(propertyName);

            if (propertyInfo == null)
                throw new ArgumentException("Property " + propertyName + " not found!");

            propertyInfo.SetValue(obj, value, null);
        }
        */
    }
}
