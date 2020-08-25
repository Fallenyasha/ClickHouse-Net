﻿namespace ClickHouse.Ado.Impl.Data {
    internal enum ClientMessageType {
        Hello = 0,

        /// Имя, версия, ревизия, БД по-умолчанию.
        Query = 1,

        /**
         * Идентификатор запроса, настройки на отдельный запрос,
         * информация, до какой стадии исполнять запрос,
         * использовать ли сжатие, текст запроса (без данных для INSERT-а).
         */
        Data = 2,

        /// Блок данных со сжатием или без.
        Cancel = 3,

        /// Отменить выполнение запроса.
        Ping = 4 /// Проверка живости соединения с сервером.
    }
}