using System;
using System.IO;
using System.Windows.Forms;

namespace RDR2ModMover
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FileManager.CheckForModFiles();

            Application.Run(new Form1());
        }
    }

    public class FileManager
    {
        static string newDirName = "ModStorage";
        static string newDirPath = Path.Combine(Environment.CurrentDirectory, newDirName);
        static string srcPath = Environment.CurrentDirectory;
        private static bool ModStatus { get; set; }

        public static string[] modFileList =
        {
            "asiloader.log",
            "dinput8.dll",
            "lml.ini",
            "ModManager.Core.dll",
            "ModManager.NativeInterop.dll",
            "NLog.dll",
            "ScriptHookRDR2.dll",
            "version.dll",
            "vfs.asi",
            "vfs.log"
        };

        public static string[] vanillaFileList =
        {
            "amd_ags_x64.dll",
            "bink2w64.dll",
            "dxilconv7.dll",
            "EOSSDK-Win64-Shipping.dll",
            "ffx_fsr2_api_dx12_x64.dll",
            "ffx_fsr2_api_vk_x64.dll",
            "ffx_fsr2_api_x64.dll",
            "NvLowLatencyVk.dll",
            "nvngx_dlss.dll",
            "oo2core_5_win64.dll",
            "steam_api64.dll",
            "RDR2.exe"
        };

        public static void MoveFiles()
        {
            if (Directory.Exists(newDirPath))
            {
                if (GetModStatus())
                {
                    foreach (string fileName in modFileList)
                    {
                        try
                        {
                            string pathFrom = Path.Combine(srcPath, fileName);
                            string pathTo = Path.Combine(newDirPath, fileName);

                            if (File.Exists(pathFrom))
                            {
                                File.Move(pathFrom, pathTo, true);
                                Console.WriteLine("File unmodded: " + fileName);
                            } else { 
                                Console.WriteLine("File not found: " + fileName);
                            }
                           
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                }
                else
                {
                    foreach (string fileName in modFileList)
                    {
                        try
                        {
                            string pathTo = Path.Combine(srcPath, fileName);
                            string pathFrom = Path.Combine(newDirPath, fileName);

                            if (File.Exists(pathFrom))
                            {
                                File.Move(pathFrom, pathTo, true);
                                Console.WriteLine("File modded: " + fileName);
                            }
                            else
                            {
                                Console.WriteLine("File not found: " + fileName);
                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                }
            }
        }

        public static void CreateFolder()
        {
            if (!Directory.Exists(newDirPath))
            {
                try
                {
                    Directory.CreateDirectory(newDirPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static void CheckForModFiles()
        {
            ModStatus = false;

            if (Directory.Exists(srcPath))
            {
                foreach (string fileName in modFileList)
                {
                    string filePath = Path.Combine(srcPath, fileName);

                    if (File.Exists(filePath))
                    {
                        ModStatus = true;
                        break;
                    }
                }
            }
        }


        public static bool GetModStatus()
        {
            return ModStatus;
        }
    }
}
