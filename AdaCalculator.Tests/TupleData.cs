using System.Collections;

namespace AdaCalculator.Tests
{
    public class TupleDataSum1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("sum", 0, 3),
                new Tuple<string, double>("sum", 3)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataSum2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("sum", 0, 0),
                new Tuple<string, double>("sum", 0)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataSum3 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("sum", -4, 10),
                new Tuple<string, double>("sum", 6)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataSubtract1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("subtract", 5, 0),
                new Tuple<string, double>("subtract", 5)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataSubtract2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("subtract", 5, 3),
                new Tuple<string, double>("subtract", 2)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataSubtract3 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("subtract", 5, 6),
                new Tuple<string, double>("subtract", -1)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataMultiply1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("multiply", 1, 0),
                new Tuple<string, double>("multiply", 0)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataMultiply2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("multiply", 2, 10),
                new Tuple<string, double>("multiply", 20)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataMultiply3 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("multiply", 5, -3),
                new Tuple<string, double>("multiply", -15)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataDivide1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("divide", 15, 3),
                new Tuple<string, double>("divide", 5)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataDivide2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("divide", 10, 1),
                new Tuple<string, double>("divide", 10)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class TupleDataDivide3 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Tuple<string, double, double>("divide", 6, 3),
                new Tuple<string, double>("divide", 2)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
