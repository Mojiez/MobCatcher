using System;
using System.Collections.Generic;
using System.Text;
using MobCatcher.GameData.Characters.Mobs;
using Xunit;

namespace MobCatcherTesting
{
    public class LevelCalculationTest
    {
        #region LevelCalculaterTest
        Mob Mob = new Mob("Bob #LevelOneMob");
        [Theory]
        #region DataInput
        [InlineData(1, 1200)]
        [InlineData(2, 1440)]
        [InlineData(3, 1728)]
        [InlineData(4, 2074)]
        [InlineData(5, 2489)]
        [InlineData(6, 2987)]
        [InlineData(7, 3584)]
        [InlineData(8, 4301)]
        [InlineData(9, 5161)]
        [InlineData(10, 6193)]
        [InlineData(11, 7432)]
        [InlineData(12, 8918)]
        [InlineData(13, 10702)]
        [InlineData(14, 12842)]
        [InlineData(15, 15410)]
        [InlineData(16, 18492)]
        [InlineData(17, 22190)]
        [InlineData(18, 26628)]
        [InlineData(19, 31954)]
        [InlineData(20, 38345)]
        [InlineData(21, 46014)]
        [InlineData(22, 55217)]
        [InlineData(23, 66260)]
        [InlineData(24, 79512)]
        [InlineData(25, 95414)]
        [InlineData(26, 114497)]
        [InlineData(27, 137396)]
        [InlineData(28, 164875)]
        [InlineData(29, 197850)]
        [InlineData(30, 237420)]
        [InlineData(31, 284904)]
        [InlineData(32, 341885)]
        [InlineData(33, 410262)]
        [InlineData(34, 492314)]
        [InlineData(35, 590777)]
        [InlineData(36, 708932)]
        [InlineData(37, 850718)]
        [InlineData(38, 1020862)]
        [InlineData(39, 1225034)]
        [InlineData(40, 1470041)]
        [InlineData(41, 1764049)]
        [InlineData(42, 2116859)]
        [InlineData(43, 2540231)]
        [InlineData(44, 3048277)]
        [InlineData(45, 3657932)]
        [InlineData(46, 4389518)]
        [InlineData(47, 5267422)]
        [InlineData(48, 6320906)]
        [InlineData(49, 7585087)]
        [InlineData(50, 9102104)]
        #endregion
        public void CalculateXpToNextLevelCalculateAmountOfXpToNextLevel_ShouldGiveTheAmountOfXpToLevel(int level, int expected)
        {
            Mob.Level = level;
            ExperinceCalculation LevelCalc = new ExperinceCalculation();
            // Arrange

            // Act
            double actual = LevelCalc.CalculateAmountOfXpToNextLevel(Mob);
            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

    }
}
