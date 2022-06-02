using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitecture.Application.Interfaces.ViewModels
{
    public interface IViewModel
    {
        //  public static ViewModel ToView(IAggregateRoot root, IMapper _mapper)
        // {
        //     var mapper = new Dictionary<Type, Func<IAggregateRoot, ViewModel>>
        //     {
        //           {typeof(UserEntity), (r) => { return _mapper.Map<UserViewModel>(r); } },
        //     };
        //     return mapper[root.GetType()](root);
        // }
    }
}
