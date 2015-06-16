
using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;



namespace CheckContracts
{
    partial class Validate
    {

        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(int value, int minValue, string errorFormat, params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value should be greater than {0}. Current value: {1}", new object[]{ value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(double value, double minValue, string errorFormat, params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value should be greater than {0}. Current value: {1}", new object[]{ value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(long value, long minValue, string errorFormat, params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value should be greater than {0}. Current value: {1}", new object[]{ value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(byte value, byte minValue, string errorFormat, params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value should be greater than {0}. Current value: {1}", new object[]{ value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }
        
        /// <summary>
        /// Checks that input value is greater (and not equal with) minValue
        /// </summary>
        public static void GreaterThan(short value, short minValue, string errorFormat, params object[] args )
        {
            if(value > minValue)
            {
                return;
            }

            var message = BuildMessage("Value should be greater than {0}. Current value: {1}", new object[]{ value, minValue }, errorFormat, args);

            throw new InvalidOperationException(message);
        }
                
    }
}