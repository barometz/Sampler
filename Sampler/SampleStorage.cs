using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sampler
{
    /// <summary>
    ///     Saves and loads <see cref="Sample" /> instances.
    /// </summary>
    /// <remarks>
    ///     Implemented as a separate static class to ensure that Sample's public interface provides all necessary
    ///     information.
    /// </remarks>
    public static class SampleStorage
    {
        /// <summary>
        ///     Data structure for easy serialization of <see cref="Sample" />s.
        /// </summary>
        [Serializable]
        private struct StoredSample
        {
            public uint SampleRate;
            public uint SampleCount;
            public uint BitDepth;
            public string WaveFunction;
        }

        public static Sample Load(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            var stored = (StoredSample) formatter.Deserialize(stream);
            stream.Close();
            return new Sample(stored.SampleRate, stored.SampleCount, stored.BitDepth, stored.WaveFunction);
        }

        public static void Save(string path, Sample sample)
        {
            StoredSample stored;
            stored.BitDepth = sample.BitDepth;
            stored.SampleCount = sample.SampleCount;
            stored.SampleRate = sample.SampleRate;
            stored.WaveFunction = sample.WaveFunction;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, stored);
            stream.Close();
        }
    }
}
