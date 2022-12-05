﻿namespace Aboriginal_Art_Gallery_of_Australia.Models.DTOs
{
    public class ArtistArtworkDto
    {
        public int ArtistId { get; set; }
        public int ArtworkId { get; set; }

        public ArtistArtworkDto(int artistId, int artworkId)
        {
            ArtistId = artistId;
            ArtworkId = artworkId;
        }
    }
}