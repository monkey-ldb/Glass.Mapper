﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glass.Mapper.Sc.FakeDb
{
    [TestFixture]
    public class ScVersionTest
    {
#if SC80
        public void Sc80()
        {
            Assert.True(true);
        }
#endif

#if SC81
        public void Sc81()
        {
            Assert.True(true);
        }
#endif
#if SC82
        public void Sc82()
        {
            Assert.True(true);
        }
#endif
#if SC90
        public void Sc90()
        {
            Assert.True(true);
        }
#endif
#if SC91
        public void Sc91()
        {
            Assert.True(true);
        }
#endif
#if SC92
        public void Sc92()
        {
            Assert.True(true);
        }
#endif

    }
}