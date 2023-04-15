﻿using System.Text.Json.Serialization;

namespace ZenTicketsLib.Models.Metrics;

public record RequesterWaitTime
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("ticket_id")]
    public int? TicketId { get; set; }

    [JsonPropertyName("metric")]
    public string Metric { get; set; } = default!;

    [JsonPropertyName("instance_id")]
    public int? InstanceId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }

    [JsonPropertyName("sla")]
    public MetricSla MetricSla { get; set; } = new();

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; } = new();
}