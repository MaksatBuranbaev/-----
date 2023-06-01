#!/usr/bin/env python
# -*- coding: utf8 -*-
from msilib import schema
import sqlite3
from flask import Flask, request, session, g, redirect, url_for, \
     abort, render_template, flash

SECRET_KEY = 'development key'
USERNAME = 'admin'
PASSWORD = 'default'

# create our little application :)
app = Flask(__name__)
app.config['JSON_AS_ASCII'] = False
app.config.from_object(__name__)

# Make the WSGI interface available at the top level so wfastcgi can get it.
wsgi_app = app.wsgi_app

def user_creation(name):
    conn = sqlite3.connect(name + '.db')
    conn.cursor(schema.sql)
    conn.commit()

def command_db(name_db, command):
    conn = sqlite3.connect(name_db)
    cur = conn.cursor()
    cur.execute(command)
    conn.commit()

@app.route('/')
def index():
    user = {"username": "JJJ"}
    user = {"вывывыв": "вфывфыв"}
    posts = [
        {
            'author': {'username': 'John'},
            'body': 'Beautiful day in Portland!'
        },
        {
            'author': {'username': 'Susan'},
            'body': 'The Avengers movie was so cool!'
        }, 
        {
            'author': {'username': 'Ипполит'},
            'body': 'Какая гадость эта ваша заливная рыба!!'
        }
    ]
    return render_template('index.html', title='Home', user=user, posts=posts)
    

if __name__ == '__main__':
    import os
    HOST = os.environ.get('SERVER_HOST', 'localhost')
    try:
        PORT = int(os.environ.get('SERVER_PORT', '5555'))
    except ValueError:
        PORT = 5555
    app.run(HOST, PORT, debug=True)

