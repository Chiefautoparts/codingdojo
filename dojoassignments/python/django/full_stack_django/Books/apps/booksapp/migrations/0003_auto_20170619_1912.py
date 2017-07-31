# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2017-06-19 19:12
from __future__ import unicode_literals

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('booksapp', '0002_auto_20170619_1912'),
    ]

    operations = [
        migrations.AlterField(
            model_name='book',
            name='author_id',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='booksapp.Author'),
        ),
    ]