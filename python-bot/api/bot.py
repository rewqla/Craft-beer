from aiogram import Bot, Dispatcher, types

from api.utils.utils import get_beer_data

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
        # Обробка помилок бази даних
        await message.reply(f"Помилка бази даних: {beer_data}")
    else:
        # Створіть рядок з отриманими даними
        response_text = ""
        for beer in beer_data:
            response_text += f"ID: {beer[0]} \n Name: {beer[1]}, \n Description: {beer[2]}\n\n"

        # Відправте відповідь користувачу
        await message.reply(response_text)
