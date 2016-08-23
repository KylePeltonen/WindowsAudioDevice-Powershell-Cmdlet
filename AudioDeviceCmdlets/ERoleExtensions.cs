using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreAudioApi;

namespace AudioDeviceCmdlets
{
    public static class ERoleExtensions
    {
            public static string ToFriendlyString(this ERole me)
            {
                switch (me)
                {
                    case ERole.eCommunications:
                        return "Communications";
                    case ERole.eConsole:
                        return "Console";
                    case ERole.eMultimedia:
                        return "Multimedia";
                    default:
                        return "Unknown";
                }
            }

            public static ERole ToERole(string value)
            {
                switch (value)
                {
                    case "Communications":
                        return ERole.eCommunications;
                    case "Console":
                        return ERole.eConsole;
                    case "Multimedia":
                        return ERole.eMultimedia;
                }

                throw new System.ComponentModel.InvalidEnumArgumentException();
            }
        }
    }
