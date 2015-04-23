using System;
namespace CsQuery
{
    public class CQ
    {
    }
}
namespace System
{

    public class MyNotImplementException : Exception
    {

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
    //namespace Linq
    //{
    //    class dummy { }
    //}
    //namespace Xml
    //{
    //    class dummy { }
    //}
}
namespace CsQuery
{

    //namespace ExtensionMethods
    //{
    //    class dummy { }
    //}
    //namespace ExtensionMethods.Internal
    //{
    //    class dummy { }
    //}
    //namespace Utility
    //{
    //    class dummy { }
    //}
    //namespace Engine
    //{
    //    class dummy { }
    //}
    //namespace HtmlParser
    //{
    //    class dummy { }
    //}
    //namespace Output
    //{
    //    class dummy { }
    //}
    //namespace StringScanner
    //{
    //    class dummy { }
    //}
    //namespace StringScanner.Implementation
    //{
    //    class dummy { }
    //}
}