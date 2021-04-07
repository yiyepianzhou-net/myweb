using Abp.Dependency;
using Abp.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class MyUnitOfWorkManager : IUnitOfWorkManager
    {
        private readonly ICurrentUnitOfWorkProvider _currentUnitOfWorkProvider;

        public IActiveUnitOfWork Current
        {
            get { return _currentUnitOfWorkProvider.Current; }
        }

        public MyUnitOfWorkManager(
            ICurrentUnitOfWorkProvider currentUnitOfWorkProvider)
        {
            _currentUnitOfWorkProvider = currentUnitOfWorkProvider;
        }

        public IUnitOfWorkCompleteHandle Begin()
        {
            return Begin(new UnitOfWorkOptions());
        }

        public IUnitOfWorkCompleteHandle Begin(TransactionScopeOption scope)
        {
            return Begin(new UnitOfWorkOptions { Scope = scope });
        }

        public IUnitOfWorkCompleteHandle Begin(UnitOfWorkOptions options)
        {
            return null;

        }
    }
}
