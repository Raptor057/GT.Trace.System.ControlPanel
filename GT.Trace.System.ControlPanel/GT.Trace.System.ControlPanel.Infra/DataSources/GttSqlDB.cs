namespace GT.Trace.System.ControlPanel.Infra.DataSources
{
    internal class GttSqlDB
    {
        private readonly DapperSqlDbConnection _con;

        public GttSqlDB(ConfigurationSqlDbConnection<GttSqlDB> con)
        {
            _con = con;
        }

    }
}
