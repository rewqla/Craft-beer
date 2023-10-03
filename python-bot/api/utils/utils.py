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

def get_order_data():
    try:
        with app.app_context():
            sql_query = text('SELECT * FROM "Orders"')
            result = db.session.execute(sql_query)
            beer_data = result.fetchall()
            return beer_data
    except SQLAlchemyError as e:
        return str(e)