from aiogram import Bot, Dispatcher, types

from api.utils.utils import get_beer_data, get_order_data

TOKEN = '5680096668:AAHuis7pyG-G4G0taF7WeumTRdU-jgGUeY0'

bot = Bot(token=TOKEN)
dp = Dispatcher(bot=bot)


@dp.message_handler(commands=['start'])
async def start_handler(message: types.Message):
    await message.reply(f"Hello")


@dp.message_handler(commands=['beers'])
async def beer_info_answer(message: types.Message):
    beer_data = get_beer_data()

    if isinstance(beer_data, str):
        await message.reply(f"Помилка бази даних: {beer_data}")
    else:
        response_text = ""
        for beer in beer_data:
            response_text += f"ID: {beer[0]} \n Name: {beer[1]}, \n Description: {beer[2]}\n\n"

        await message.reply(response_text)

@dp.message_handler(commands=['order'])
async def beer_info_answer(message: types.Message):
    order_data = get_order_data()

    if isinstance(order_data, str):
        await message.reply(f"Помилка бази даних: {order_data}")
    else:
        response_text = ""
        for order in order_data:
            response_text += f"ID: {order[0]} \n Unique Code: {order[1]}, \n Date: {order[2]} \n Status: {order[3]} \n Name: {order[4]} \n Surname: {order[5]} \n Phone: {order[6]} \n City: {order[7]} \n Delivery: {order[8]}\n\n"

        await message.reply(response_text)