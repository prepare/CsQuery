using System;

namespace System
{
    namespace Collections.Generic
    {
        public interface ISet<T> : IEnumerable<T>, ICollection<T>
        {
           
        }
        //public class SortedSet<T>
        //{

        //}
    }

    public class MyNotImplementException : Exception
    {
        //TODO: find this exception in the code 
        //and reimplement it again
    }
    namespace Collections.Generic
    {
        public static class CollectionExtensionMethods
        {
            public static List<T> ToList<T>(this IEnumerable<T> iter)
            {
                List<T> list = new List<T>(iter);
                return list;
            }
            public static T[] ToArray<T>(this IEnumerable<T> iter)
            {
                List<T> list = new List<T>(iter);
                return list.ToArray();
            }
        }
        public class HashSet<T>
        {
            public HashSet()
            {
            }
            public HashSet(IEnumerable<T> iter)
            {

            }
            public void Add(T t)
            {

            }
            public bool Contains(T t)
            {
                throw new MyNotImplementException();
            }
        }

    }

    //namespace Collections.Concurrent
    //{
    //    class dummy { }
    //}
    namespace Linq
    {
        class dummy { }
    }
    //namespace Xml
    //{
    //    class dummy { }
    //}
}
namespace CsQuery
{
    namespace Implementation
    {
        class dummy { }
    }
    namespace ExtensionMethods
    {
        class dummy { }
    }
    namespace ExtensionMethods.Internal
    {
        class dummy { }
    }
    namespace Utility
    {
        class dummy { }
    }
    namespace Engine
    {
        class dummy { }
    }
    namespace HtmlParser
    {
        class dummy { }
    }
    namespace Output
    {
        class dummy { }
    }
    namespace StringScanner
    {
        class dummy { }
    }
    namespace StringScanner.Implementation
    {
        class dummy { }
    }
}