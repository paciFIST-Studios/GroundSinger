using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SquareGrid_test
    {
        [Test]
        public void SquareGrid_IsNotConstructible_AtSizeZeroZero()
        {
            var sg = new SquareGrid(0, 0);
            Assert.AreEqual(0, sg.Width);
            Assert.AreEqual(0, sg.Height);
        }

        [Test]
        public void SquareGrid_IsConstructible_AtSizeOneOne()
        {
            var sg = new SquareGrid(1, 1);
            Assert.AreEqual(1, sg.Width);
            Assert.AreEqual(1, sg.Height);
        }

        [Test]
        public void SquareGrid_IsNotConstructible_AtSizeMinusOneMinusOne()
        {
            var sg = new SquareGrid(-1, -1);
            Assert.AreEqual(0, sg.Width);
            Assert.AreEqual(0, sg.Height);
        }

        [Test]
        public void SquareGrid_IsConstructible_AtSizeMaxSide()
        {
            var sg = new SquareGrid(SquareGrid.MAX_SIDE, SquareGrid.MAX_SIDE);
            Assert.AreEqual(SquareGrid.MAX_SIDE, sg.Width);
            Assert.AreEqual(SquareGrid.MAX_SIDE, sg.Height);
        }

        [Test]
        public void SquareGrid_IsNotConstructible_AtSizeGreaterThanMaxSide()
        {
            var sg = new SquareGrid(SquareGrid.MAX_SIDE + 1, SquareGrid.MAX_SIDE + 1);
            Assert.AreEqual(SquareGrid.MAX_SIDE, sg.Width);
            Assert.AreEqual(SquareGrid.MAX_SIDE, sg.Height);
        }


    }
}
