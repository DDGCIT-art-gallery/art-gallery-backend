using Aboriginal_Art_Gallery_of_Australia.Models.DTOs;

namespace Aboriginal_Art_Gallery_of_Australia.Persistence.Interfaces
{
    public interface IMediaDataAccess
    {
        /// <summary>
        /// Retrieves a complete list of media types from the database/repository.
        /// </summary>
        /// <returns>Returns the collection of media types as a list.</returns>
        List<MediaOutputDto> GetMediaTypes();

        /// <summary>
        /// Retrieves the media type matching the specified ID from the database/repository.
        /// </summary>
        /// <returns>Returns the matching media type if successful or null if unsuccessful.</returns>
        MediaOutputDto? GetMediaTypeById(int id);

        /// <summary>
        /// Inserts a media type into the database/repository.
        /// </summary>
        /// <param name="media">The new media type to be inserted.</param>
        /// <returns>Returns a copy of the inserted media type if successful or null if unsuccessful.</returns>
        MediaInputDto? InsertMediaType(MediaInputDto media);

        /// <summary>
        /// Updates the media type matching the specified ID in the database/repository.
        /// </summary>
        /// <param name="media">The updated media type details</param>
        /// <returns>Returns a copy of the updated media type if successful or null if unsuccessful.</returns>
        MediaInputDto? UpdateMediaType(int id, MediaInputDto media);

        /// <summary>
        /// Delete the media type matching the specified ID from the database/repository.
        /// </summary>
        /// <param name="id">The specified media type ID to be matched.</param>
        /// <returns>Returns the result of the delete operation as a boolean value.</returns>
        bool DeleteMediaType(int id);
    }
}