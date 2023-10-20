from sqlalchemy import text
from sqlalchemy.exc import SQLAlchemyError

from api.app import app, db


def get_beer_data():
    try:
        with app.app_context():
            sql_query = text('SELECT * FROM "CraftBeers"')
            result = db.session.execute(sql_query)
            beer_data = result.fetchall()
            return beer_data
    except SQLAlchemyError as e:
        return str(e)


def get_order_data(unique_code):
    try:
        with app.app_context():
            sql_query = text('''
                SELECT
                    o."Id" AS "OrderId",
                    o."UniqueCode" AS "OrderUniqueCode",
                    o."Date" AS "OrderDate",
                    os."Name" AS "OrderStatus",
                    ci."FirstName" AS "CustomerFirstName",
                    ci."LastName" AS "CustomerLastName",
                    ci."Phone" AS "CustomerPhone",
                    da."City" AS "DeliveryCity",
                    da."Address" AS "DeliveryAddress"
                FROM
                    "Orders" AS o
                LEFT JOIN
                    "OrderStatuses" AS os ON o."OrderStatusId" = os."Id"
                LEFT JOIN
                    "CustomerInfos" AS ci ON o."CustomerInfoId" = ci."Id"
                LEFT JOIN
                    "DeliveryAddresses" AS da ON o."DeliveryAddressId" = da."Id"
                WHERE o."UniqueCode" = :unique_code
            ''')
            result = db.session.execute(sql_query, {'unique_code': unique_code})
            order_data = result.fetchall()
            return order_data
    except SQLAlchemyError as e:
        return str(e)


def get_user_order_data(phone):
    try:
        with app.app_context():
            sql_query = text('''
                SELECT
                    o."Id" AS "OrderId",
                    o."UniqueCode" AS "OrderUniqueCode",
                    o."Date" AS "OrderDate",
                    os."Name" AS "OrderStatus",
                    ci."FirstName" AS "CustomerFirstName",
                    ci."LastName" AS "CustomerLastName",
                    ci."PhoneNumber" AS "CustomerPhone",
                    da."City" AS "DeliveryCity",
                    da."Address" AS "DeliveryAddress"
                FROM
                    "Orders" AS o
                LEFT JOIN
                    "OrderStatuses" AS os ON o."OrderStatusId" = os."Id"
                LEFT JOIN
                    "AspNetUsers" AS ci ON o."CustomerInfoId" = ci."Id"
                LEFT JOIN
                    "DeliveryAddresses" AS da ON o."DeliveryAddressId" = da."Id"
                WHERE ci."PhoneNumber" = :Phone
            ''')
            result = db.session.execute(sql_query, {'Phone': phone})
            order_data = result.fetchall()
            return order_data
    except SQLAlchemyError as e:
        return str(e)
