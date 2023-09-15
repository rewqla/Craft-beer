from flask import Flask
from flask_sqlalchemy import SQLAlchemy
from flask_restful import Api

app = Flask(__name__)
api = Api(app)


app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://ugpzeyle:YeOgrDWyliwZw3nd6TYa2szz4bWGT6ok@tai.db.elephantsql.com:5432/ugpzeyle'
app.config["SQLALCHEMY_TRACK_MODIFICATIONS"] = False

db = SQLAlchemy(app)

if __name__ == '__main__':
    app.run()