﻿using OsuPlayer.Api.Data.API.Enums;

namespace OsuPlayer.Api.Data.API.RequestModels.Beatmap;

public class SearchBeatmapModel
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 64;
    public string? Artist { get; set; }
    public string? Title { get; set; }
    public string? BeatmapSetId { get; set; }
    public string? BeatmapId { get; set; }
    
    public FilterCondition ArtistFilterCondition { get; set; }
    public FilterCondition TitleFilterCondition { get; set; }
    public FilterCondition BeatmapSetIdFilterCondition { get; set; }
    public FilterCondition BeatmapIdFilterCondition { get; set; }
    
}