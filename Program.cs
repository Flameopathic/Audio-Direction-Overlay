using NAudio.CoreAudioApi;
using Microsoft.Maui;

MMDeviceEnumerator deviceEnumerator = new();
MMDevice device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
int leftVolume = (int)(device.AudioMeterInformation.PeakValues[0]);
int rightVolume = (int)(device.AudioMeterInformation.PeakValues[1]);
Console.WriteLine(leftVolume.ToString());
Console.WriteLine(rightVolume.ToString());
