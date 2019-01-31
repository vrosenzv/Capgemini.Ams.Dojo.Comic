namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters
{
    /// <summary>Base class for API query parameter</summary>
    public abstract class VineBaseParameter
    {
        /// <summary>Contains value for the parameter filter</summary>
        public string value { get; }

        /// <summary></summary>
        /// <param name="parameterValue"></param>
        protected VineBaseParameter(string parameterValue)
            => this.value = parameterValue;

        /// <summary>Specify the webService name of the parameter</summary>
        public abstract string Name { get; }

        public string ToQueryString()
            => $"{this.Name}:{this.value}";
    }
}