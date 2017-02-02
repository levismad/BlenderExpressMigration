
using static Levismad.Utils.ValidationUtil;

namespace Levismad.Model
{
    public interface IModel
    {
        ValidatorResult Validar();
    }
}
