from api.app import db


class Order(db.Model):
    __tablename__ = 'orders'  # Назва таблиці в базі даних

    id = db.Column(db.Integer, primary_key=True)
    unique_code = db.Column(db.String(255))
    date = db.Column(db.String(255))
    user_id = db.Column(db.Integer, db.ForeignKey('users.id'))
    order_status_id = db.Column(db.Integer, db.ForeignKey('order_statuses.id'))
    customer_info_id = db.Column(db.Integer, db.ForeignKey('customer_info.id'))
    delivery_address_id = db.Column(db.Integer, db.ForeignKey('delivery_addresses.id'))

    user = db.relationship('User', backref='orders')
    order_status = db.relationship('OrderStatus', backref='orders')
    customer_info = db.relationship('CustomerInfo', backref='orders')
    delivery_address = db.relationship('DeliveryAddress', backref='orders')
    order_items = db.relationship('OrderItem', backref='order')
