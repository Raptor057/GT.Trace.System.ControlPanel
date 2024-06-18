namespace GT.Trace.System.ControlPanel.Infra.DataSources
{
    public class ConfigurationSqlDbConnection<T> : DapperSqlDbConnection
    {
        public ConfigurationSqlDbConnection(ConfigurationSqlDbConnectionFactory<T> factory)
            : base(factory)
        { }
    }
}
