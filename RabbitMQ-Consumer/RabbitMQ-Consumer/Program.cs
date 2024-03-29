﻿using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};
var connection = factory.CreateConnection();
var channel = connection.CreateModel();
channel.QueueDeclare("demo-queue",
    durable: true,
    exclusive: false,
    autoDelete: false,
    arguments: null);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (sender, e) => 
{
    var body = e.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine(message);
};channel.BasicConsume("demo-queue", true,consumer);
Console.ReadLine();
