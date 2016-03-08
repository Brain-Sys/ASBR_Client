using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASBR_Client
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "urn:ps")]
    interface IProblemSolver
    {
        [OperationContract]
        int AddNumbers(int a, int b);
    }

    interface IProblemSolverChannel : IProblemSolver, IClientChannel { }
}