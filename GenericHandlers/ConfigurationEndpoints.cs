using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;

namespace GenericHandlers;

internal static class ConfigurationEndpoints
{
    public static IEndpointRouteBuilder MapConfigurationRoutes(this IEndpointRouteBuilder builder)
    {
        builder.MapInstallationUpdate("/installation/{id}/approve-pull-requests", async (
            IConfigurationRepository repository,
            InstallationId id,
            bool value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateApproveAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/approve-pull-requests", async (
            IConfigurationRepository repository,
            RepositoryId id,
            bool? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateApproveAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/approval-comment", async (
            IConfigurationRepository repository,
            InstallationId id,
            string value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateApproveCommentAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/approval-comment", async (
            IConfigurationRepository repository,
            RepositoryId id,
            string? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateApproveCommentAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/auto-merge", async (
            IConfigurationRepository repository,
            InstallationId id,
            bool value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateAutomergeAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/auto-merge", async (
            IConfigurationRepository repository,
            RepositoryId id,
            bool? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateAutomergeAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/deployment", async (
            IConfigurationRepository repository,
            InstallationId id,
            bool value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/deployment", async (
            IConfigurationRepository repository,
            RepositoryId id,
            bool? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/deployment-comment", async (
            IConfigurationRepository repository,
            InstallationId id,
            string value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentCommentAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/deployment-comment", async (
            IConfigurationRepository repository,
            RepositoryId id,
            string? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentCommentAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/deployment-environments", async (
            IConfigurationRepository repository,
            InstallationId id,
            IList<string> values,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentEnvironmentsAsync(id, values, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/deployment-environments", async (
            IConfigurationRepository repository,
            RepositoryId id,
            IList<string>? values,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateDeploymentEnvironmentsAsync(id, values, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/is-disabled", async (
            IConfigurationRepository repository,
            InstallationId id,
            bool value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateIsDisabledAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/is-disabled", async (
            IConfigurationRepository repository,
            RepositoryId id,
            bool? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateIsDisabledAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/merge-method", async (
            IConfigurationRepository repository,
            InstallationId id,
            string value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdatePullRequestMergeMethodAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/merge-method", async (
            IConfigurationRepository repository,
            RepositoryId id,
            string? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdatePullRequestMergeMethodAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/release-freezes", async (
            IConfigurationRepository repository,
            InstallationId id,
            IList<ReleaseFreeze> value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateReleaseFreezesAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/release-freezes", async (
            IConfigurationRepository repository,
            RepositoryId id,
            IList<ReleaseFreeze>? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateReleaseFreezesAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/status-checks", async (
            IConfigurationRepository repository,
            InstallationId id,
            IList<string> value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateStatusChecksAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/status-checks", async (
            IConfigurationRepository repository,
            RepositoryId id,
            IList<string>? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateStatusChecksAsync(id, value, cancellationToken);
        });

        builder.MapInstallationUpdate("/installation/{id}/status-check-attempts", async (
            IConfigurationRepository repository,
            InstallationId id,
            int value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateStatusCheckAttemptsAsync(id, value, cancellationToken);
        });

        builder.MapRepositoryUpdate("/installation/{installationId}/repository/{repositoryId}/status-check-attempts", async (
            IConfigurationRepository repository,
            RepositoryId id,
            int? value,
            CancellationToken cancellationToken) =>
        {
            return await repository.UpdateStatusCheckAttemptsAsync(id, value, cancellationToken);
        });

        return builder;
    }

    private static RouteHandlerBuilder MapInstallationUpdate<T>(
        this IEndpointRouteBuilder endpoints,
        string pattern,
        Func<IConfigurationRepository, InstallationId, T, CancellationToken, Task<bool>> operation)
    {
        return endpoints.MapPatch(pattern, async (
            long id,
            [FromBody] Payload<T> request,
            InstallationService service,
            IConfigurationRepository repository,
            CancellationToken cancellationToken) =>
        {
            if (!await service.UserHasAccessToInstallationAsync(id))
            {
                return Results.NotFound();
            }

            return await operation(repository, new(id), request.Value, cancellationToken) switch
            {
                false => Results.Conflict(),
                true => Results.NoContent(),
            };
        }).RequireAuthorization()
          .ValidateAntiforgery();
    }

    private static RouteHandlerBuilder MapRepositoryUpdate<T>(
        this IEndpointRouteBuilder endpoints,
        string pattern,
        Func<IConfigurationRepository, RepositoryId, T, CancellationToken, Task<bool>> operation)
    {
        return endpoints.MapPatch(pattern, async (
            long installationId,
            long repositoryId,
            [FromBody] Payload<T> request,
            InstallationService service,
            IConfigurationRepository repository,
            CancellationToken cancellationToken) =>
        {
            if (!await service.UserHasAccessToRepositoryAsync(installationId, repositoryId))
            {
                return Results.NotFound();
            }

            await repository.EnsureRepositoryAsync(repositoryId, cancellationToken);

            return await operation(repository, new(repositoryId), request.Value, cancellationToken) switch
            {
                false => Results.Conflict(),
                true => Results.NoContent(),
            };
        }).RequireAuthorization()
          .ValidateAntiforgery();
    }

    private static TBuilder ValidateAntiforgery<TBuilder>(this TBuilder builder)
        where TBuilder : IEndpointConventionBuilder
    {
        return builder.AddEndpointFilter(async (context, next) =>
        {
            var httpContext = context.HttpContext;
            var antiforgery = httpContext.RequestServices.GetRequiredService<IAntiforgery>();

            try
            {
                await antiforgery.ValidateRequestAsync(httpContext);
            }
            catch (AntiforgeryValidationException)
            {
                return Results.BadRequest("Antiforgery token validation failed.");
            }

            return await next(context);
        });
    }

    private sealed record Payload<T>(T Value);
}
