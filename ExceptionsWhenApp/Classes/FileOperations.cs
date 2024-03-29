﻿using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ExceptionsWhenApp.Classes
{
    public class FileOperations
    {
        public static (string[] list, Exception exception) ReadFileConventional(string fileName)
        {
            try
            {
                return (File.ReadAllLines(fileName), null);
            }
            catch (Exception localException)
            {
                return (null, localException);
            }
        }

        /// <summary>
        /// Assumes caller asserted that the file exists prior to calling this method.
        /// Novice developers tend not to assert if the file exists
        /// </summary>
        public static (string[] list, string message) ReadFileWithWhenFilter(string fileName)
        {
            try
            {
                return (File.ReadAllLines(fileName), null);
            }
            catch (Exception localException) 
                when (localException.Message.Contains("Could not find file", StringComparison.OrdinalIgnoreCase))
            {
                return (null, $"'{fileName}' is missing dude");
            }
            catch (Exception localException) 
                when (localException.Message.Contains("denied", StringComparison.OrdinalIgnoreCase))
            {
                return (null, $"insufficient rights to {fileName}");
            }
            catch (Exception localException) 
                when (localException.Message.Contains("The process cannot access", StringComparison.OrdinalIgnoreCase))
            {
                return (null, $"Someone has {fileName} opened exclusively");
            }
            catch (Exception localException)
            {
                return (null, localException.Message);
            }
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample for exceptions/when";
        }
    }
}