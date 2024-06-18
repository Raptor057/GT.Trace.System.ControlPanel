namespace GT.Trace.System.ControlPanel.Infra.DataSources
{
    internal class TrazaSqlDB
    {
        private readonly DapperSqlDbConnection _con;

        public TrazaSqlDB(ConfigurationSqlDbConnection<TrazaSqlDB> con)
        {
            _con = con;
        }
    }
}
