using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example
{
    public class DI
    {
        public readonly IVehicle iVehicle;

        //Constructor injection
        //Propertey injection
        //Method Injection
        public DI(IVehicle iVehicle)
        {
            this.iVehicle = iVehicle;
        }

        public void SearchDetails(string model)
        {
            iVehicle.Models(model);
        }
    }


    public class VehicleDetails
    {

        public void TVSDetails(string Vehicle)
        {
            if (Vehicle == "Apachee")
            {
                Console.WriteLine("Vehicle Name:Apachee");
                Console.WriteLine("Vehicle Color:red");
                Console.WriteLine("Vehicle CC:200cc");
                Console.WriteLine("Vehicle Variant:top");

            }else if(Vehicle == "Raider")
            {
                Console.WriteLine("Vehicle Name:Raider");
                Console.WriteLine("Vehicle Color:white");
                Console.WriteLine("Vehicle CC:125cc");
                Console.WriteLine("Vehicle Variant:middle");

            }
        }
        public void HondaDetails(string Vehicle)
        {
            if (Vehicle == "unicorn")
            {
                Console.WriteLine("Vehicle Name:unicorn");
                Console.WriteLine("Vehicle Color:red");
                Console.WriteLine("Vehicle CC:160cc");
                Console.WriteLine("Vehicle Variant:top");

            }
            else if (Vehicle == "shine")
            {
                Console.WriteLine("Vehicle Name:shine");
                Console.WriteLine("Vehicle Color:black");
                Console.WriteLine("Vehicle CC:125cc");
                Console.WriteLine("Vehicle Variant:middle");

            }

        }
    }


    public interface IVehicle
    {
      void Models(string Model);
      void price();
    }

    public class TVSvehicle: IVehicle
    {

        public void Models(string Model)
        {
            if (Model == "Apachee")
            {
                Apachee();
            }
            else if (Model == "Raider")
            {
                Raider();
            }

        }

        public void Apachee()
        {
            Console.WriteLine("Vehicle Name:Apachee");
            Console.WriteLine("Vehicle Color:red");
            Console.WriteLine("Vehicle CC:200cc");
            Console.WriteLine("Vehicle Variant:top");

        }

        public void Raider()
        {
            Console.WriteLine("Vehicle Name:Raider");
            Console.WriteLine("Vehicle Color:white");
            Console.WriteLine("Vehicle CC:125cc");
            Console.WriteLine("Vehicle Variant:middle");

        }

        public void price()
        {
            throw new NotImplementedException();
        }
    }

    public class Hondavehicle : IVehicle
    {
        public void Models(string Model)
        {
            if (Model == "Unicorn")
            {
                Unicorn();
            }
            else if (Model == "Shine")
            {
                Shine();
            }

        }

        public void Unicorn()
        {
            Console.WriteLine("Vehicle Name:unicorn");
            Console.WriteLine("Vehicle Color:red");
            Console.WriteLine("Vehicle CC:160cc");
            Console.WriteLine("Vehicle Variant:top");

        }

        public void Shine()
        {
            Console.WriteLine("Vehicle Name:shine");
            Console.WriteLine("Vehicle Color:black");
            Console.WriteLine("Vehicle CC:125cc");
            Console.WriteLine("Vehicle Variant:middle");

        }

        public void price()
        {
            throw new NotImplementedException();
        }
    }
    public class InMemoryCacheExample
    {
        private readonly IMemoryCache _cache;

        public InMemoryCacheExample(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void SetCacheData()
        {
            // Setting a cache item with a 5-minute expiration
            _cache.Set("CacheKey", "Cached data", new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });
        }

        public string GetCacheData()
        {
            // Retrieving the cached item
            if (_cache.TryGetValue("CacheKey", out string cachedValue))
            {
                return cachedValue;
            }

            return "Cache is empty";
        }
    }

    public class CustomCacheExample
    {
        private static readonly ConcurrentDictionary<string, string> _customCache = new ConcurrentDictionary<string, string>();

        public void SetCacheData(string key, string value)
        {
            _customCache[key] = value;
        }

        public string GetCacheData(string key)
        {
            return _customCache.TryGetValue(key, out var value) ? value : "Cache is empty";
        }
    }

}
