namespace GT.Trace.System.ControlPanel.Infra.DataSources
{
    internal class AppsSqlDB
    {
        private readonly DapperSqlDbConnection _con;

        public AppsSqlDB(ConfigurationSqlDbConnection<AppsSqlDB> con)
        {
            _con = con;
        }
    }
}
