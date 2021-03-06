﻿using ExpertSender.Common;
using ExpertSender.DataModel.Dao;
using Multi.WebDaoTests.Core;

namespace Multi.WebDaoTests.DaoTests
{
    internal class DomainDaoTests : Tester
    {
        private const int CurrentUnitId = 1;

        public override void Start()
        {
            var app = Container.GetInstance<IEsAppContext>();
            app.CurrentServiceId = CurrentUnitId;

            ClearDomainFamiliesInDwTest1();
            ClearDomainFamiliesInDwTest2();
            ClearDomainFamiliesInDwTest3();
            ClearDomainFamiliesInDwTest4();
        }

        public void ClearDomainFamiliesInDwTest1()
        {
            var dao = Container.GetInstance<IDomainDao>();
            dao.Use(CurrentUnitId);

            dao.ClearDomainFamiliesInDw(CurrentUnitId, 0, 1000);
        }

        public void ClearDomainFamiliesInDwTest2()
        {
            var dao = Container.GetInstance<IDomainDao>();
            dao.Use(CurrentUnitId);

            dao.ClearDomainFamiliesInDw(CurrentUnitId, 0, 0);
        }

        public void ClearDomainFamiliesInDwTest3()
        {
            var dao = Container.GetInstance<IDomainDao>();
            dao.Use(CurrentUnitId);

            dao.ClearDomainFamiliesInDw(CurrentUnitId, 4, 21);
        }

        public void ClearDomainFamiliesInDwTest4()
        {
            var dao = Container.GetInstance<IDomainDao>();
            dao.Use(CurrentUnitId);

            dao.ClearDomainFamiliesInDw(CurrentUnitId, 4, 1000);
        }
    }
}
