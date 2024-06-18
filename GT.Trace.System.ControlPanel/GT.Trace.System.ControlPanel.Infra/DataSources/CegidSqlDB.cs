namespace GT.Trace.System.ControlPanel.Infra.DataSources
{
    internal class CegidSqlDB
    {
        private readonly DapperSqlDbConnection _con;

        public CegidSqlDB(ConfigurationSqlDbConnection<CegidSqlDB> con)
        {
            _con = con;
        }
    }
}
